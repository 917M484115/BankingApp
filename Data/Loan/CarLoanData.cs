namespace BankingApp.Data.Loan
{
    public sealed class CarLoanData : LoanData
    {
        public string CarType { get; set; }
        public double CarValue { get; set; }
        public int CarAge { get; set; }
    }
}
