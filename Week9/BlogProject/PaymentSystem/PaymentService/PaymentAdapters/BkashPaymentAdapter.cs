using System;
using BlogProject.PaymentSystem.MobileFinancialService;

namespace BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

public class BkashPaymentAdapter : IPayment
{
    private Bkash _bkash;
    public BkashPaymentAdapter(Bkash bkash)
    {
        this._bkash = bkash;
    }

    public bool makePayment(string accountId)
    {
        return _bkash.payBill(Int64.Parse(accountId));
    }
}


