using System;

namespace _10011027_accessment3_question2
{
    class Falcon
    {

        private string _FalconName;
        private string _Species;
        private string _Sex;
        private string _Weight;
        private string _BandNumber;;






        public string FalconName

        {

            set

            {

                _FalconName = value;

            }

        }






        public string Species

        {

            set

            {

                _Species= value;

            }

        }

   public string Sex

        {

            set

            {

                _Sex= value;

            }

        }

public string Weight

        {

            set

            {

                _Weight= value;

            }

        }




        public string BandNumber

        {

            set

            {

                _BandNumber = value;

            }

        }






        public Falcon(string _FalconName, string _Species, string _Sex, string _Weight, int _BandNumber)

        {

           FalconName = _FalconName;

           Species = _Species;
           Sex = _Sex;
           Weight = _Weight;
           BandNumber = _BandNumber;

        }

        public string DisplayFalcon()

        {

            var showmyFalcon = "The Falcon we have created is:\n\n";

            showmyFalcon += $"The FalconName is: {_FalconName}\n";

            showmyFalcon += $"The Species is: {_Species}\n";

            showmyFalcon += $"The Sex is: {_Sex}\n";

            showmyFalcon += $"The Weight is: {_Weight}\n";

            showmyFalcon += $"The  BandNumber is: {_ BandNumber}\n";

            return showmyFalcon;

        }

    }


    class Program

    {

        static void Main(string[] args)

        {

            var FalconName = Hisan;

            var Species = NZ Falcon;

            var Sex = Male;
            var Weight = 240grams;
            var BandNumber = H39878;
            






            Console.WriteLine(FalconName.DisplayFalcon());

            Console.WriteLine(Species.DisplayFalcon());

            Console.WriteLine(Sex.DisplayFalcon());

            Console.WriteLine(Weight.DisplayFalcon());

            Console.WriteLine(BandNumber.DisplayFalcon());

        }

    }
