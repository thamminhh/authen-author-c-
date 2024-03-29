﻿namespace JwtWebAPITutorial.Entities_SubModel.ContractGroup.SubModel
{
    public class ContractGroupCreateModel
    {

        public int? UserId { get; set; }

        public string? RentPurpose { get; set; }

        public DateTime? RentFrom { get; set; }

        public DateTime? RentTo { get; set; }

        public string? RequireDescriptionInfoCarBrand { get; set; }

        public int? RequireDescriptionInfoSeatNumber { get; set; }

        public int? RequireDescriptionInfoYearCreate { get; set; }

        public string? RequireDescriptionInfoCarColor { get; set; }

        public string? CustomerName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? CustomerSocialInfoZalo { get; set; }

        public string? CustomerSocialInfoFacebook { get; set; }

        public string? CustomerSocialInfoLinkedin { get; set; }

        public string? CustomerSocialInfoOther { get; set; }

        public string? AddtionalInfo { get; set; }

        public string? RelativeTel { get; set; }

        public bool? ExpertiseInfoIsFirstTimeRent { get; set; }

        public string? ExpertiseInfoTrustLevel { get; set; }

        public string? CompanyInfo { get; set; }

        public string? CitizenIdentifyImage1 { get; set; }

        public string? CitizenIdentifyImage2 { get; set; }

        public string? DrivingLisenceImage1 { get; set; }

        public string? DrivingLisenceImage2 { get; set; }

        public string? HousePaperImages { get; set; }

        public string? PassportImages { get; set; }

        public string? OtherImages { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
