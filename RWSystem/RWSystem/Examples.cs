using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem
{
  public static class Examples
  {
    public const string Example1Sc =
      "¬calm triggers Test" + "\n" +
      "Test causes calm" + "\n" +
      "disable OralExam between 0, 2" + "\n" +
      "OralExam typically causes ¬calm if ¬corruption" + "\n" +
      "OralExam causes ¬corruption" + "\n" +
      "Test invokes Oral exam after 3" + "\n" +
      "Cleaning causes corruption" + "\n" +
      "disable Oral exam between 7, 1000" + "\n" +
      "disable Test between 7, 1000";

    public const string Example2Sc =
      "disable Control between 0, 2" + "\n" +
      "ActivateTicket typically causes ticketValid" + "\n" +
      "PlayWithTicket releases ticketValid if ticketValid" + "\n" +
      "Control causes fine if ¬ticketValid" + "\n" +
      "Control invokes PayFine if ¬ticketValid" + "\n" +
      "PayFine causes ¬fine, ticketV alid if fine";

    public const string Example3Sc =
      "Work typically causes workDone if ¬workDone and rested" + "\n" +
      "Work causes ¬rested if ¬workDone and rested" + "\n" +
      "¬rested triggers Rest" + "\n" +
      "Rest causes rested";
  }
}
