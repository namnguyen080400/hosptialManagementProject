using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystems
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            string[] roleType = {"Select Role", "Patient", "Doctor", "Nurse", "Staff" };
            comboBoxUserType.DataSource = roleType;
            comboBoxUserType.SelectedIndex = 0;
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // get all inputs from user
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string dob = textBoxDOB.Text;
            string gender = textBoxGender.Text;
            string email = textBoxEmail.Text;
            string homePhone = textBoxHomePhone.Text;
            string mobilePhone = textBoxMobilePhone.Text;
            string streetNumber = textBoxAddressNumber.Text;
            string streetName = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string state = textBoxState.Text;
            string zipCode = textBoxZipCode.Text;

            if (checkRegistrationValidty()) // user entered all the fields
            {
                // query to make sure if username is already exist in database
                var query = from login in hospitalContext.Logins
                            where login.Username == username
                            select new
                            {
                                Username = $"{login.Username}"
                            };
                if (query.Count() > 0) // existing username is in the database
                {
                    MessageBox.Show("Username is already taken");
                }
                else // username is not in the database
                {
                    // add new login to the database
                    Login newLogin = new Login
                    {
                        Username = username,
                        Passwords = password
                    };
                    hospitalContext.Logins.InsertOnSubmit(newLogin);
                    hospitalContext.SubmitChanges();

                    // add new address to database
                    AddressName newAddress = new AddressName
                    {
                        Number = Int32.Parse(streetNumber),
                        Street = streetName,
                        City = city,
                        StateName = state,
                        ZipCode = Int32.Parse(zipCode)
                    };
                    hospitalContext.AddressNames.InsertOnSubmit(newAddress);
                    hospitalContext.SubmitChanges();

                    // add new people to database
                    People newPeople = new People
                    {
                        LoginId = newLogin.LoginId,
                        RoleId = comboBoxUserType.SelectedIndex,
                        AddressId = newAddress.AddressId,
                        FirstName = firstName,
                        LastName = lastName,
                        DateOfBirth = DateTime.Parse(dob),
                        Gender = gender
                    };
                    hospitalContext.Peoples.InsertOnSubmit(newPeople);
                    hospitalContext.SubmitChanges();

                    ContactInfo newContact = new ContactInfo
                    {
                        AddressId = newAddress.AddressId,
                        HomePhone = homePhone,
                        MobilePhone = mobilePhone,
                        Email = email
                    };
                    hospitalContext.ContactInfos.InsertOnSubmit(newContact);
                    hospitalContext.SubmitChanges();

                    if (comboBoxExpertise.SelectedIndex == 2)
                    {
                        Doctor newDoctor = new Doctor
                        {
                            UserId = newPeople.UserId,
                            Expertise = comboBoxExpertise.SelectedValue.ToString()
                        };
                        hospitalContext.Doctors.InsertOnSubmit(newDoctor);
                        hospitalContext.SubmitChanges();
                    }
                    MessageBox.Show("Sign up sucessful");
                }
            }
        }

        // helper function to check if user entered all required fields
        private bool checkRegistrationValidty()
        {
            bool result = true;

            if (textBoxFirstName.Text == "")
            {
                MessageBox.Show("Please enter first name.");
                return false;
            }
            if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Please enter last name.");
                return false;
            }
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Please enter username.");
                return false;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter password.");
                return false;
            }
            if (textBoxDOB.Text == "")
            {
                MessageBox.Show("Please enter date of birth.");
                return false;
            }
            if (textBoxGender.Text == "")
            {
                MessageBox.Show("Please enter gender.");
                return false;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Please enter email address.");
                return false;
            }
            if (textBoxHomePhone.Text == "")
            {
                MessageBox.Show("Please enter home phone.");
                return false;
            }
            if (textBoxMobilePhone.Text == "")
            {
                MessageBox.Show("Please enter mobile phone.");
                return false;
            }
            if (textBoxAddressNumber.Text == "")
            {
                MessageBox.Show("Please enter address number.");
                return false;
            }
            if (textBoxStreet.Text == "")
            {
                MessageBox.Show("Please enter adddress street.");
                return false;
            }
            if (textBoxCity.Text == "")
            {
                MessageBox.Show("Please enter city.");
                return false;
            }
            if (textBoxState.Text == "")
            {
                MessageBox.Show("Please enter state.");
                return false;
            }
            if (textBoxZipCode.Text == "")
            {
                MessageBox.Show("Please enter zip code.");
                return false;
            }
            return result;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxDOB.Clear();
            textBoxGender.Clear();
            textBoxEmail.Clear();
            textBoxHomePhone.Clear();
            textBoxMobilePhone.Clear();
            textBoxAddressNumber.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxState.Clear();
            textBoxZipCode.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxExpertise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserType.SelectedIndex == 2)
            {
                string[] expertiseType = { "Select expertise","Primary care physician", "Allergists", "Anesthesiologists", "Cardiologists",
                                        "Colon and Rectal Surgeons", "Dermatologists", "Endocrinologists", "Gastroenterologists"};
                comboBoxExpertise.DataSource = expertiseType;
                comboBoxExpertise.SelectedIndex = 0;
            }
        }
    }
}
