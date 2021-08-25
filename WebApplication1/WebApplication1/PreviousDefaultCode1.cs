//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//namespace WebApplication1
//{
//    public partial class _Default : Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//            //  only if there is nothing in the Session variable
//            //  
//            if (Session["TokenQueue"] == null)
//            {
//                Queue<int> queueTokens = new Queue<int>();

//                //  web application work on stateless protocol
//                //  so it must be stored in a session variable or a database, xml etc
//                // 
//                //  the key is called TokenQueue
//                // 
//                Session["TokenQueue"] = queueTokens;
//            }

//            //if (Session["CountriesData"] == null)
//            //{
//            //    Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
//            //    Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
//            //    Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washigton D.C." };
//            //    Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
//            //    Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

//            //    Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>()
//            //{
//            //    { country1.Code, country1 },
//            //    { country2.Code, country2 },
//            //    { country3.Code, country3 },
//            //    { country4.Code, country4 },
//            //    { country5.Code, country5 },

//            //};

//            //    Session["CountriesData"] = dictionaryCountries;
//            //}


//        }

//        protected void btnPrintToken_Click(object sender, EventArgs e)
//        {
//            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

//            //  first tell the user how many Customers are in the queue
//            //  before them
//            // 
//            lblStatus.Text = "There are " + tokenQueue.Count.ToString()
//                + " customers before you in the queue";

//            //  check if there are no items in the queue i.e no token number have been
//            //  issued yet, null the first time so store 0 in the session variable
//            //  
//            if (Session["LastTokenNumberIssued"] == null)
//            {
//                Session["LastTokenNumberIssued"] = 0;
//            }

//            //  the next token number will be incremeted by 1 when clicked
//            //
//            int nextTokenNumberToBeIssued =
//                (int)Session["LastTokenNumberIssued"] + 1;

//            //  store back in the Session variable so next time it can be
//            //  computed
//            //
//            // add to the tokenQueue with Enqueue 
//            //
//            Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
//            tokenQueue.Enqueue(nextTokenNumberToBeIssued);

//            AddTokensToListBox(tokenQueue);

//        }

//        //  if there are items within the ListBox clear them
//        //  then add them to the ListBox
//        //
//        private void AddTokensToListBox(Queue<int> tokenQueue)
//        {
//            listTokens.Items.Clear();
//            foreach (int token in tokenQueue)
//            {
//                listTokens.Items.Add(token.ToString());
//            }
//        }

//        protected void btnCounter1_Click(object sender, EventArgs e)
//        {
//            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

//            //  if 0, there are no customers in the Queue
//            //
//            if (tokenQueue.Count == 0)
//            {
//                txtCounter1.Text = "No Customers in the Queue";
//            }
//            else
//            {
//                //  if there are items in the Queue, Dequeue the item i.e
//                //  remove the item in the queue and store it
//                //
//                int tokenNumberToBeServed = tokenQueue.Dequeue();
//                txtCounter1.Text = tokenNumberToBeServed.ToString();
//                txtDisplay.Text = " Token number : " + tokenNumberToBeServed.ToString() +
//                    " Please go to counter 1";

//                //  remove the item from the ListBox
//                //  
//                AddTokensToListBox(tokenQueue);
//            }

//        }

//        protected void btnCounter2_Click(object sender, EventArgs e)
//        {

//        }

//        protected void btnCounter3_Click(object sender, EventArgs e)
//        {

//        }


//        //protected void txtCountryCode_TextChanged(object sender, EventArgs e)
//        //{
//        //    //  Session["CountriesData"] will return an object therefore 
//        //    //  a cast to Dictionary needed
//        //    // 
//        //    Dictionary<string, Country> dictionaryCountries =
//        //        (Dictionary<string, Country>)Session["CountriesData"];

//        //    string strUserChoice = string.Empty;

//        //    //  txtCountryCode will accept the user info i.e txtCountryCode.Text.ToUpper()
//        //    // 
//        //    Country resultCountry = 
//        //           dictionaryCountries.ContainsKey(txtCountryCode.Text.ToUpper())
//        //           ? dictionaryCountries[txtCountryCode.Text.ToUpper()]
//        //           : null;

//        //    if (resultCountry == null)
//        //    {
//        //        //  instead of Console display in label and text boxes
//        //        // 
//        //        Label1.Text = "Country code not valid ";
//        //        txtCapital.Text = "";
//        //        txtNames.Text = "";
//        //    }
//        //    else
//        //    {
//        //        txtNames.Text = resultCountry.Name;
//        //        txtCapital.Text = resultCountry.Capital;
//        //    }

//        //}


//    }

//    public class Employee
//    {
//        public int EmployeeId { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//    }

//    public class Company
//    {
//        private List<Employee> employees;

//        public Company()
//        {
//            employees = new List<Employee>()
//            {
//                new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" },
//                new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" },
//                new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" },
//                new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" },
//                new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "Female" },
//                new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" },
//                new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" },
//                new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" }
//            };
//        }


//        //  "Company class has got only one indexer with one parameter which is 
//        //  of type integer"
//        public string this[int employeeID]
//        {
//            get
//            {
//                return employees.FirstOrDefault(emp => emp.EmployeeId == employeeID).Name;
//            }
//            set
//            {
//                employees.FirstOrDefault(emp => emp.EmployeeId == employeeID).Name = value;
//            }
//        }

//        // overloading indexer
//        public string this[string gender]
//        {
//            get
//            {
//                //  Count returns an integer so a cast to string is needed
//                return employees.Count(emp => emp.Gender == gender).ToString();
//            }
//            set
//            {
//                foreach (Employee employee in employees)
//                {
//                    if (employee.Gender == gender)
//                    {
//                        employee.Gender = value;
//                    }
//                }
//            }
//        }

//    }











//    public interface IEmployee
//    {
//        void EmployeeMethod();
//    }

//    public interface ICustomer
//    {
//        void CustomerMethod();

//    }


//}