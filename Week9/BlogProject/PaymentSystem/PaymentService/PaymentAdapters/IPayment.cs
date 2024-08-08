using System;

namespace BlogProject.PaymentSystem.PaymentService.PaymentAdapters;

public interface IPayment
{
    bool makePayment(string accountId);
}


