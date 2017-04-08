using System;
using System.Collections.Generic;
using System.Text;

namespace Example05
{
    public delegate void doAction();
    class Button
    {
        public event doAction clickEvent;
        public void eventRaise()
        {
            clickEvent();
        }
    }
    class EventHandler
    {
        public void ButonClickHandler()
        {
            Console.WriteLine("You have clicked button");
        }
    }
    class Run
    {
        static void Main(string[] args)
        {
            //tao doi tuong chua event
            Button btnOK = new Button();
            //tao doi tuong chua phuong thuc xu ly su kien
            EventHandler objEventHandler = new EventHandler();
            //subcrible event to delegate
            btnOK.clickEvent += new doAction(objEventHandler.ButonClickHandler);
            //raise event click
            btnOK.eventRaise();

        }
    }

}
