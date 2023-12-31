﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<int> Add(Payment payment);
        IDataResult<Payment> GetLastPaymentOfCustomer(int customerId);
    }
}
