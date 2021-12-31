using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace PaySheet
{/*Домашнее задание: Serialization. 
Разработать класс «Счет для оплаты». В классе предусмотреть следующие поля:  
■ оплата за день;
■ количество дней;
■ штраф за один день задержки оплаты;
■ количество дней задержи оплаты;
■ сумма к оплате без штрафа (вычисляемое поле); 
■ штраф (вычисляемое поле);
■ общая сумма к оплате (вычисляемое поле).  
В  классе  объявить  статическое  свойство  типа  bool,  значение  которого  влияет  на 
процесс  форматирования  объектов  этого  класса.  Если  значение  этого  свойства  равно 
true,  тогда  сериализуются  и  десериализируются  все  поля,  если  false  -  вычисляемые 
поля не сериализуются.  */
    [Serializable]
    class PaySheet : ISerializable
    {
        public static bool Flag { get; set; } = true;
        public double DayPayment { get; set; }
        public int TotalDays { get; set; }
        public double FineforOneDayDelay { get; set; }
        public int NumberDaysPaymentDelays { get; set; }

        public double SumToPayWithoutFine { get; private set; }
        public double Fine { get; private set; }
        public double TotalAmountToPay { get; private set; }

        public PaySheet()
        {
            SumToPayWithoutFine = DayPayment * TotalDays;
            Fine = FineforOneDayDelay * NumberDaysPaymentDelays;
            TotalAmountToPay = SumToPayWithoutFine + Fine;
        }
        //[OnDeserialized]
        //private void OnDeserialised(StreamingContext context)
        //{
        //        SumToPayWithoutFine = DayPayment * TotalDays;
        //        Fine = FineforOneDayDelay * NumberDaysPaymentDelays;
        //        TotalAmountToPay = SumToPayWithoutFine + Fine;
        //}

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            SumToPayWithoutFine = DayPayment * TotalDays;
            Fine = FineforOneDayDelay * NumberDaysPaymentDelays;
            TotalAmountToPay = SumToPayWithoutFine + Fine;
        }

        public override string ToString()
        {
            return $"DayPayment: { DayPayment}\n" +
                   $"TotalDays: {TotalDays}\n" +
                   $"FineforOneDayDelay: { FineforOneDayDelay}\n" +
                   $"SumToPayWithoutFine: {SumToPayWithoutFine}\n"+
                   $"Fine: {Fine}\n"+
                   $"TotalAmountToPay: {TotalAmountToPay}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             if (Flag)
            {
                info.AddValue("SumToPayWithoutFine", SumToPayWithoutFine);
                info.AddValue("Fine", Fine);
                info.AddValue("TotalAmountToPay", TotalAmountToPay);
            }
            info.AddValue("DayPayment", DayPayment);
            info.AddValue("TotalDays", TotalDays);
            info.AddValue("FineforOneDayDelay", FineforOneDayDelay);
            info.AddValue("NumberDaysPaymentDelays", NumberDaysPaymentDelays);
            info.AddValue("Flag", Flag);

        }

        private PaySheet(SerializationInfo info, StreamingContext context)
        {
             Flag = info.GetBoolean("Flag");
              if (Flag)
            {
                SumToPayWithoutFine = info.GetDouble("SumToPayWithoutFine");
                Fine = info.GetDouble("Fine");
                TotalAmountToPay = info.GetDouble("TotalAmountToPay");
            }
            DayPayment = info.GetDouble("DayPayment");
            TotalDays = info.GetInt32("TotalDays");
            FineforOneDayDelay = info.GetDouble("FineforOneDayDelay");
            NumberDaysPaymentDelays = info.GetInt32("NumberDaysPaymentDelays");


        }


    }
}
