﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        Task<IDataResult<List<CreditCard>>> GetAllCreditCard();
        Task<IDataResult<List<CreditCard>>> GetCardsByCustomerId(Guid customerId);
        IResult AddCreditCard(CreditCard creditCard);
        IResult DeleteCreditCard(CreditCard creditCard);
        IResult UpdateCreditCard(CreditCard creditCard);
        Task<IDataResult<CreditCard>> GetCreditCardByIdAsync(Guid creditCardId);
        IDataResult<bool> CheckCreditCard(CreditCard creditCard);
        IDataResult<bool> SaveCreditCard(Guid customerId, string cardNumber);
    }
}
