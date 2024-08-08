using System;
using BlogProject.PaymentSystem.MobileFinancialService;

namespace BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

public class PaypalPaymentAdapter : IPayment
{
    private Paypal _paypal;
    public PaypalPaymentAdapter(Paypal paypal)
    {
        this._paypal = paypal;
    }

    public bool makePayment(string accountId)
    {
        var response = _paypal.BillPay(accountId);
        return response;
    }
}
