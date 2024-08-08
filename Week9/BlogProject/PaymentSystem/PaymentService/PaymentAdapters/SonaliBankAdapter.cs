using System;
using BlogProject.PaymentSystem.BankPaymentImported;

namespace BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

public class SonaliBankAdapter : IPayment
{
    private SonaliBank _sonaliBank;
    public SonaliBankAdapter(SonaliBank sonaliBank)
    {
        this._sonaliBank = sonaliBank;
    }

    public bool makePayment(string accountId)
    {
        var response = _sonaliBank.make_payment(accountId);
        if(response == "payment successful")
        {
            return true;
        }
        return false;
    }
}
