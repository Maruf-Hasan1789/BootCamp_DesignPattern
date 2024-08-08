using System;
using BlogProject.PaymentSystem.BankPaymentImported;
using BlogProject.PaymentSystem.MobileFinancialService;
using BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

namespace BlogProject.PaymentSystem.PaymentService;

public class AdapterFactory
{
    public IPayment getPaymentMethod(PaymentMethods paymentsystem)
    {
        if(paymentsystem == PaymentMethods.Bkash)
        {
            return new BkashPaymentAdapter(new Bkash());
        }
        else if(paymentsystem == PaymentMethods.Paypal)
        {
            return new PaypalPaymentAdapter(new Paypal());
        }
        else if(paymentsystem == PaymentMethods.SonaliBank)
        {
            return new SonaliBankAdapter(new SonaliBank());
        }
        else
        {
            return new BracBankAdapter(new BracBank());
        }
    }
}
