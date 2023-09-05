using System;
namespace delegates
{
    public delegate void WelcomeString(String s);
    class program
    {
        event WelcomeString myevent;
        program()
        {
            this.myevent = new WelcomeString(this.Welcome);
            this.myevent+= new WelcomeString(this.Hello);

        }
        public void Welcome(String s)
        {
            Console.WriteLine("Welcome" + s);
        }
        public void Hello(string s) 
        {
            Console.WriteLine("Hello" + s);
        }
        static void Main(String[] args) {
            program p = new program();
            p.myevent("Sanjay");
        }
    }
}

