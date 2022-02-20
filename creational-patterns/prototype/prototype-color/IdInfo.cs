
/// <summary>
/// Internal Object for Person objects
/// </summary>
public class IdInfo
    {
        public int IdNumber;
        public DateTime ExpirationDate;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
            this.ExpirationDate = DateTime.Today.AddYears(6);
        }

    }