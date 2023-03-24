using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3_2
{
    internal class Program
    {
        class SmsMessage
        {
            private string _messagetext;
            private int _maxlength;
            private double _initialprice;
            private double _symbolprice;
            public string MessageText
            {
                get
                {
                    return _messagetext;
                }
                private set
                {
                    _messagetext = NormalizeMessageText(value, _maxlength);
                }
            }
            public int MaxLength
            {
                get
                {
                    return _maxlength;
                }
                private set
                {
                    _maxlength = value;
                }
            }
            public double InitialPrice
            {
                get
                {
                    return _initialprice;
                }
                private set
                {
                    _initialprice = value;
                }
            }
            public double SymbolPrice
            {
                get
                {
                    return _symbolprice;
                }
                private set
                {
                    _symbolprice = value;
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice(_initialprice, _symbolprice);
                }
            }
            public SmsMessage(string text, int length, double initialprice, double symbolprice)
            {
                MessageText = text;
                MaxLength = length;
                InitialPrice = initialprice;
                SymbolPrice = symbolprice;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{_messagetext}' длиной {_messagetext.Length} символов и стоимостью {Price} руб.");
            }
            private string NormalizeMessageText(string text, int length)
            {
                if (text.Length > length)
                {
                    return text.Substring(0, text.Length - length);
                }
                return text;
            }
            private double CalculatePrice(double initialprice, double symbolprice)
            {
                if (_messagetext.Length < 65)
                {
                    return initialprice;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return initialprice + length * symbolprice;
                }
            }
        }
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("Я снова пообещал все, что смог, ведь это любовь еще одной темной ночью.", 100, 2, 0.9);
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}