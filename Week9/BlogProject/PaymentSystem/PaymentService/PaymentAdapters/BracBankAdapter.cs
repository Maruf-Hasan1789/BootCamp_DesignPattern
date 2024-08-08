using System;
using BlogProject.PaymentSystem.BankPaymentImported;

namespace BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

public class BracBankAdapter : IPayment
{
    private BracBank _bracBank;
    public BracBankAdapter(BracBank bracBank)
    {
        this._bracBank = bracBank;
    }

    public bool makePayment(string accountId)
    {
        var response = _bracBank.DoPayment(Int64.Parse(accountId));
        if(response == "payment done")
        {
            return true;
        }
        return false;
    }
}
