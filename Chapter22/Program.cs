using System;

namespace Chapter22
{
    class Program
    {
        static void Main(string[] args)
        {
            Massage msg = new Massage();
            msg.MsgId = 1;
            msg.ProducId = 1;
            msg.Qty = 21;
            msg.Price = 5.99 * msg.Qty;

            Console.WriteLine("Answering to the mail {0}" +
                " you can buy {1} quantity of item {2}" +
                " on total price {3}.",msg.MsgId,msg.Qty,msg.ProducId
                ,msg.Price);
        }
    }
    public struct ColorList
    {
        private string[] names;
        public string this[int i]
        { get => names[i]; set => names[i] = value; }
        public void Add(string ColorName)
        {
            if (names == null)
            {
                names = new string[1];
                names[0] = ColorName;
            }
            else
            {
                //names = names.Concat<string>(new string[] { ColorName}).toArray;
            }
        }
        public int Length { get => names.Length; }
        
    }

    public struct Massage
    {
        public int MsgId;
        public int ProducId;
        public int Qty;
        public double Price;
        public Massage(int masID , int prodId, int Quant)
        {
            MsgId = masID;
            ProducId = prodId;
            Qty = Quant;
            if (prodId > 22 )
            {
                Price = 5.99 * Quant;
            }
            else
            {
                Price = 7.99 * Quant;
            }
        }
    }
}
