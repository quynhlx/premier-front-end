//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace debt_fe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vw_Member
    {
        public int MemberISN { get; set; }
        public string memUserName { get; set; }
        public string memPassword { get; set; }
        public string memFirstName { get; set; }
        public string memMiddleName { get; set; }
        public string memLastName { get; set; }
        public string memSSN { get; set; }
        public string memEmail { get; set; }
        public string memAddress { get; set; }
        public string memCity { get; set; }
        public string memState { get; set; }
        public string memZip { get; set; }
        public string memCountry { get; set; }
        public string memPhone { get; set; }
        public string memFax { get; set; }
        public byte memStatus { get; set; }
        public Nullable<System.DateTime> memSignUp { get; set; }
        public Nullable<short> memTimeOption { get; set; }
        public Nullable<byte> memDayLightSaving { get; set; }
        public Nullable<System.DateTime> memPinCreateDate { get; set; }
        public Nullable<int> memPinDisableBy { get; set; }
        public Nullable<int> BatchISN { get; set; }
        public Nullable<int> PromotionISN { get; set; }
        public Nullable<int> AgentISN { get; set; }
        public byte memAutoRecharge { get; set; }
        public Nullable<decimal> memLowerThan { get; set; }
        public Nullable<decimal> memWithAmount { get; set; }
        public Nullable<int> PaymentProfileISN { get; set; }
        public string memHomePhone { get; set; }
        public string memMobilePhone { get; set; }
        public string memWorkPhone { get; set; }
        public Nullable<decimal> memCreditLine { get; set; }
        public string memDomainName { get; set; }
        public Nullable<byte> memRechargeBlock { get; set; }
        public Nullable<byte> memInvoice { get; set; }
        public double memAllPinUsage { get; set; }
        public double memCurrPinUsage { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public Nullable<int> updatedBy { get; set; }
        public Nullable<System.DateTime> memAgentDate { get; set; }
        public Nullable<System.DateTime> memDOB { get; set; }
        public Nullable<int> memAddedBy { get; set; }
        public string memFullName { get; set; }
        public string memFullName2 { get; set; }
        public Nullable<double> memBalance { get; set; }
        public Nullable<int> ProgramISN { get; set; }
        public string prgName { get; set; }
        public string memPinNumber { get; set; }
        public Nullable<byte> memPinStatus { get; set; }
        public string pmtCode { get; set; }
        public string agtName { get; set; }
        public string updatedName { get; set; }
        public Nullable<int> LanguageISN { get; set; }
        public string Language { get; set; }
        public int memType { get; set; }
        public int IsChangePin { get; set; }
        public int IsContactRequest { get; set; }
        public int memMonthlySales { get; set; }
        public string bchName { get; set; }
        public Nullable<byte> PCodeUpdated { get; set; }
        public string memCompanyName { get; set; }
        public string memTitle { get; set; }
        public string memIM { get; set; }
        public Nullable<byte> memVerified { get; set; }
        public string memComment { get; set; }
        public string memPolycomID { get; set; }
        public Nullable<double> memCreditScore { get; set; }
        public Nullable<decimal> memApprovalPayment { get; set; }
        public Nullable<decimal> memApprovalAmount { get; set; }
        public Nullable<int> CampaignISN { get; set; }
        public string cpnName { get; set; }
        public string cpnDID { get; set; }
        public Nullable<int> DealerISN { get; set; }
        public Nullable<int> AdsAgencyISN { get; set; }
        public byte PreferredLanguage { get; set; }
        public string memTimeZoneFull { get; set; }
        public string memWeekDay { get; set; }
        public string memOnSaturday { get; set; }
        public string memOnSunday { get; set; }
        public Nullable<byte> memTradeVehicle { get; set; }
        public string memYearVehicle { get; set; }
        public string memManufacturerVehicle { get; set; }
        public string memModelVehicle { get; set; }
        public Nullable<decimal> memMonthlyPayment { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<decimal> memHomeValue { get; set; }
        public Nullable<decimal> memCurrentLeftOnLoan { get; set; }
        public Nullable<double> memInterestRate { get; set; }
        public Nullable<decimal> memMonthlyPaymentM { get; set; }
        public Nullable<decimal> memAppoxTotalDebt { get; set; }
        public string memTypeOfLoan { get; set; }
        public string memAnyLatePayment { get; set; }
        public string memApprovalOfRCredit { get; set; }
        public string memIsYourCreditGreat { get; set; }
        public string DealerSaleman { get; set; }
        public string dealerName { get; set; }
        public Nullable<decimal> memPayOffAmount { get; set; }
        public Nullable<byte> memConnectedLO { get; set; }
        public string RoutedPhoneNumber { get; set; }
        public string rBackupPhone { get; set; }
        public string TypeOfLoan { get; set; }
        public Nullable<byte> memReadyPurchaseNow { get; set; }
        public string BestTimeOfCall { get; set; }
        public Nullable<double> PoolSpa2 { get; set; }
        public Nullable<double> TaxableIncome3 { get; set; }
        public Nullable<double> AC4 { get; set; }
        public Nullable<double> LoanModify5 { get; set; }
        public string Ownership7 { get; set; }
        public string RatePlan8 { get; set; }
        public string HERO9 { get; set; }
        public Nullable<double> BillAmount10 { get; set; }
        public string Carrier11 { get; set; }
        public Nullable<double> LowWinterBill { get; set; }
        public Nullable<double> HighSummerBill { get; set; }
        public Nullable<double> AverageBill { get; set; }
        public string FICO18 { get; set; }
        public string Financing19 { get; set; }
        public Nullable<double> PeriodOwnedHome { get; set; }
        public Nullable<double> ProductSolar { get; set; }
        public Nullable<double> ProductCore { get; set; }
        public Nullable<double> RefinancingProcess { get; set; }
        public string memDropID { get; set; }
        public string UniversalUserName { get; set; }
        public string UniversalPassword { get; set; }
        public string MasterMFACode { get; set; }
        public string EPPSUserName { get; set; }
        public string EPPSPassword { get; set; }
    }
}
