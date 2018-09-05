// Matthew Nowakowski
// Lab 6 - PersonV2 Class

using System;
using ValidationLibrary;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Console {
	class PersonV2 : Person {
		public PersonV2() {
			cellPhone = "";
			facebook = "";

            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_MNowakowski;User Id=SE245_MNowakowski;Password=001392657";
            tableName = "Persons";
		}

        private String tableName;

		private String
			cellPhone,
			facebook;

        private SqlConnection sqlConn;

        public bool AddRecord() {
            bool result = false;
            if (!inputValid) return result;

            
            String sql = "INSERT INTO " + tableName;

            sql += " (FName, MName, LName, Street1, Street2, City, State, Zip, Phone, CellPhone, Facebook) ";
            sql += "VALUES (@Fname, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @CellPhone, @Facebook)";

            SqlCommand sqlComm = new SqlCommand(sql, sqlConn);
			sqlComm.Parameters.AddWithValue("@FName", FirstName);
			sqlComm.Parameters.AddWithValue("@MName", MiddleName);
			sqlComm.Parameters.AddWithValue("@LName", LastName);
			sqlComm.Parameters.AddWithValue("@Street1", Street1);
			sqlComm.Parameters.AddWithValue("@Street2", Street2);
			sqlComm.Parameters.AddWithValue("@City", City);
			sqlComm.Parameters.AddWithValue("@State", State);
			sqlComm.Parameters.AddWithValue("@Zip", Zip);
			sqlComm.Parameters.AddWithValue("@Phone", Phone);
			sqlComm.Parameters.AddWithValue("@CellPhone", CellPhone);
			sqlComm.Parameters.AddWithValue("@Facebook", FaceBook);

			try {
                sqlConn.Open();
				int numRecordsAffected = sqlComm.ExecuteNonQuery();
				feedback += numRecordsAffected + " rows inserted.";
                sqlConn.Close();
				result = true;
            } catch (Exception e) { feedback += "Error: " + e.Message + "\n"; }

            return result;
        }

		// Can be empty
		public String CellPhone {
			get { return cellPhone; }
			set {
				if(Validator.IsValidPhone(value) || value == "") cellPhone = value;
				else {
					feedback += "Error: Cell phone is not formatted correctly\n";
					inputValid = false;
				}
			}
		}

		// Can be empty
		public String FaceBook {
			get { return facebook; }
			set {
				if(Validator.IsValidURL(value) || value == "") facebook = value;
				else {
					feedback += "Error: FaceBook url is invalid\n";
					inputValid = false;
				}
			}
		}
	}
}
