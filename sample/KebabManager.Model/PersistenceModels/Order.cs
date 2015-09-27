﻿using System;
using KebabManager.Contracts.Common;
using KebabManager.Model.Components;
using Pizza.Contracts.Default.Persistence;
using Pizza.Contracts.Persistence.Attributes;

namespace KebabManager.Model.PersistenceModels
{
    //public class OrderInfo : Base
    //{
    //    public virtual string Text { get; set; }
    //}

    //public class OrderDetails : Base
    //{
    //    public virtual string Text { get; set; }
    //    public virtual OrderInfo AdditionalInfo { get; set; }

    //    public OrderDetails()
    //    {
    //        this.AdditionalInfo = new OrderInfo();
    //    }
    //}

    public class Order : PersistenceModelBase
    {
        public Order()
        {
            this.PaymentInfo = new PaymentInfo();
        }

        public virtual Customer Customer { get; set; }
        public virtual PaymentInfo PaymentInfo { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual int ItemsCount { get; set; }
        public virtual double TotalPrice { get; set; }
        public virtual OrderType Type { get; set; }

        //public virtual OrderDetails Details { get; set; }

        [AllowNull]
        public virtual string Note { get; set; }

    }
}