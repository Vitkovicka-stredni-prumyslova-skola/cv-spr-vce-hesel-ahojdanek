namespace SpravceHesel
{
    interface IHeslo
    {
        int DelkaHesla();
        int maxDelkaHesla();
        int minDelkaHesla();

    }

    class Heslo: IHeslo
    {
        private string heslo; 
        public static int maxDelkaHesla = 20;
        private static int minDelkaHesla = 8;
        private string [] maleZnaky = {""}
        public int DelkaHesla(){
            return 0;
        }
        public int MaxDelkaHesla(){
            return maxDelkaHesla;
        }
        public int MinDelkaHesla(){
            return minDelkaHesla;
        
        }
        public static string GeneratorHesla(int pocetZnakuHesla){
            
            return 0;
        }
            
    }
}