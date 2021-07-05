﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetByOrderId(int orderId);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
