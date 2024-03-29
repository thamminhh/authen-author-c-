﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtWebAPITutorial.Entities_SubModel.ExpertiseContract;
public class ExpertiseContractUpdateModel
{
    public int Id { get; set; }
    public int ContractGroupId { get; set; }
    public int ExpertiserId { get; set; }
    public DateTime? ExpertiseDate { get; set; }
    public string? Description { get; set; }
    public string? Result { get; set; }
    public string? ResultOther { get; set; }
    public string? TrustLevel { get; set; }
    public string? DepositInfoDescription { get; set; }
    public double? DepositInfoAsset { get; set; }
    public double? DepositInfoDownPayment { get; set; }
    public double? PaymentAmount { get; set; }
    public int? ContractStatusId { get; set; }
}
