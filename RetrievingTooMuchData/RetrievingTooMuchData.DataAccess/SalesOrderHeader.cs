﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetrievingTooMuchData.DataAccess
{
    public class SalesOrderHeader
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)
        public byte RevisionNumber { get; set; } // RevisionNumber
        public DateTime OrderDate { get; set; } // OrderDate
        public DateTime DueDate { get; set; } // DueDate
        public DateTime? ShipDate { get; set; } // ShipDate
        public byte Status { get; set; } // Status
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag
        public string SalesOrderNumber { get; internal set; } // SalesOrderNumber
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber
        public string AccountNumber { get; set; } // AccountNumber
        public int CustomerId { get; set; } // CustomerID
        public int? SalesPersonId { get; set; } // SalesPersonID
        public int? TerritoryId { get; set; } // TerritoryID
        public int BillToAddressId { get; set; } // BillToAddressID
        public int ShipToAddressId { get; set; } // ShipToAddressID
        public int ShipMethodId { get; set; } // ShipMethodID
        public int? CreditCardId { get; set; } // CreditCardID
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode
        public int? CurrencyRateId { get; set; } // CurrencyRateID
        public decimal SubTotal { get; set; } // SubTotal
        public decimal TaxAmt { get; set; } // TaxAmt
        public decimal Freight { get; set; } // Freight
        public decimal TotalDue { get; internal set; } // TotalDue
        public string Comment { get; set; } // Comment
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public virtual SalesPerson SalesPerson { get; set; }

        public SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }
}