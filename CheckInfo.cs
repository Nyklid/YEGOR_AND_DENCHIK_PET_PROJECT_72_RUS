namespace calc
{
    internal class CheckInfo
    {
        private int gavno { get; set; }
        private int mocha { get; set; }


        public CheckInfo(int gavno, int mocha)
        {
            this.gavno = gavno;
            this.mocha = mocha;
        }

        public int addition(int gavno, int mocha)
        {
            return gavno + mocha;
        }

        public int multiply(int gavno, int mocha)
        {
            return gavno * mocha;
        }

        public int divide(int gavno, int mocha)
        {
            return gavno / mocha;
        }

        public int modulo(int gavno, int mocha)
        {
            return gavno % mocha;
        }

        public int subtraction(int gavno, int mocha)
        {
            return gavno - mocha;
        }
    }
}
