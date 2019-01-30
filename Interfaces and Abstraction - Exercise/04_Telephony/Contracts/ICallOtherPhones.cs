namespace Telephony.Contracts
{
    public  interface ICallOtherPhones
    {
        /// <summary>
        /// Method for Calling Numbers
        /// </summary>
        /// <param name="number">GSM Number</param>
       void CallNumber(string number);
    }
}