// Matthew Nowakowski
// Lab 7 - PersonV2 Class

using System;
using ValidationLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7 {
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

		public DataSet SearchRecords(String fName, String mName, String lName, String street1, String street2, String city,
			String state, String zip, String phone, String cellPhone, String facebook) {

			SqlCommand sqlComm = new SqlCommand();
			sqlComm.Connection = sqlConn;

			String sql = "SELECT *";
			sql += " FROM " + tableName;
			sql += " WHERE 0=0";

			if (fName.Length != 0) {
				sql += " AND FName LIKE @FName";
				sqlComm.Parameters.AddWithValue("@FName", '%' + fName + '%');
			}
			if (mName.Length != 0) {
				sql += " AND MName LIKE @MName";
				sqlComm.Parameters.AddWithValue("@MName", '%' + mName + '%');
			}
			if (lName.Length != 0) {
				sql += " AND LName LIKE @LName";
				sqlComm.Parameters.AddWithValue("@LName", '%' + lName + '%');
			}
			if (street1.Length != 0) {
				sql += " AND Street1 LIKE @Street1";
				sqlComm.Parameters.AddWithValue("@Street1", '%' + street1 + '%');
			}
			if (street2.Length != 0) {
				sql += " AND Street2 LIKE @Street2";
				sqlComm.Parameters.AddWithValue("@Street2", '%' +street2 + '%');
			}
			if (city.Length != 0) {
				sql += " AND City LIKE @City";
				sqlComm.Parameters.AddWithValue("@City", '%' + city + '%');
			}
			if (state.Length != 0) {
				sql += " AND State LIKE @State";
				sqlComm.Parameters.AddWithValue("@State", '%' + state + '%');
			}
			if (zip.Length != 0) {
				sql += " AND Zip LIKE @Zip";
				sqlComm.Parameters.AddWithValue("@Zip", '%' + zip + '%');
			}
			if (phone.Length != 0) {
				sql += " AND Phone LIKE @Phone";
				sqlComm.Parameters.AddWithValue("@Phone", '%' + phone + '%');
			}
			if (cellPhone.Length != 0) {
				sql += " AND CellPhone LIKE @CellPhone";
				sqlComm.Parameters.AddWithValue("@CellPhone", '%' + cellPhone + '%');
			}
			if(facebook.Length != 0) {
				sql += " AND Facebook LIKE @Facebook";
				sqlComm.Parameters.AddWithValue("@Facebook", '%' + facebook + '%');
			}
			sqlComm.CommandText = sql;

			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter();
			try {
				sqlConn.Open();
				da.SelectCommand = sqlComm;
				da.Fill(ds, "Persons");
				sqlConn.Close();
			} catch (Exception e) { feedback += "Error: " + e.Message; }
			return ds;
		}

		public SqlDataReader GetRecord(int id) {
			String sql = "SELECT *";
			sql += " FROM " + tableName;
			sql += " WHERE ID = @Id";
			SqlCommand sqlComm = new SqlCommand(sql, sqlConn);
			sqlComm.Parameters.AddWithValue("@Id", id);

			SqlDataReader reader = null;
			try {
				sqlConn.Open();
				reader = sqlComm.ExecuteReader();
			} catch (Exception e) { feedback += "ERROR: " + e.Message;  }

			return reader;
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
