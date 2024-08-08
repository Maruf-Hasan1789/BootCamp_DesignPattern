using System;
using BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

namespace BlogProject.PaymentSystem.PaymentService;

public class PaymentService
{
    private AdapterFactory _adapterFactory;
    public PaymentService(AdapterFactory adapterFactory)
    {
        _adapterFactory = adapterFactory;
    }

    public bool MakePayment(PaymentMethods paymentMethodType,string accountId)
    {
        IPayment paymentMethod = _adapterFactory.getPaymentMethod(paymentMethodType);
        var isPayemntSuccessful = paymentMethod.makePayment(accountId);
        return isPayemntSuccessful;
    }
}

public enum PaymentMethods
{
    Bkash,
    Paypal,
    SonaliBank,
    BracBank
}