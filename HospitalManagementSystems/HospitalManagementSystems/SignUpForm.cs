using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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

            string[] gender = { "Select gender", "Male", "Female" };
            comboBoxGender.DataSource = gender;
            comboBoxGender.SelectedIndex = 0;

            string[] state = { "Select State", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
                              "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas",
                              "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
                              "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                              "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                              "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
                              "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
                              "West Virginia", "Wisconsin", "Wyoming"}; 
            comboBoxStateName.DataSource = state;
            comboBoxStateName.SelectedIndex = 0;

            string[] ethnicity = { "Select ethnicity", "Caucasian", "African", "Caribbean", "Indian", "Melanesian", "Australasian/Aboriginal",
                                    "Chinese", "Guamanian", "Japanese", "Korean", "Polynesian", "European/Anglo Saxon",
                                    "Other Pacific Islander", "Latin American", "Arabic", "Vietnamese", "Micronesian",
                                    "Other Hispanic", "US or Canadian Indian", "Other Asian", "Puerto Rican", "Filipino",
                                    "Mexican", "Alaskan Native", "Cuban"};
            comboBoxEthnicity.DataSource = ethnicity;
            comboBoxEthnicity.SelectedIndex = 0;

            comboBoxExpertise.Visible = false;
            labelExpertise.Visible = false;

            labelPrimaryDoctor.Visible = false;
            textBoxPrimaryDoctor.Visible = false;
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();

        // function to handle sign up button click
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // get all inputs from user
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string dob = textBoxDOB.Text;
            string gender = comboBoxGender.SelectedValue.ToString();
            string ethnicity = comboBoxEthnicity.SelectedValue.ToString();
            string email = textBoxEmail.Text;
            string homePhone = textBoxHomePhone.Text;
            string mobilePhone = textBoxMobilePhone.Text;
            string streetNumber = textBoxAddressNumber.Text;
            string streetName = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string state = comboBoxStateName.SelectedValue.ToString();
            string zipCode = textBoxZipCode.Text;
            string primaryDoctor = textBoxPrimaryDoctor.Text;

            if (comboBoxEthnicity.SelectedIndex == 0)
            {
                ethnicity = null;
            }
            if (textBoxHomePhone.Text == "")
            {
                homePhone = null;
            }
            if (textBoxPrimaryDoctor.Text == "")
            {
                primaryDoctor = null;
            }

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
                        Gender = gender,
                        Ethnicity = ethnicity
                    };
                    hospitalContext.Peoples.InsertOnSubmit(newPeople);
                    hospitalContext.SubmitChanges();

                    // add new contact to database
                    ContactInfo newContact = new ContactInfo
                    {
                        AddressId = newAddress.AddressId,
                        HomePhone = homePhone,
                        MobilePhone = mobilePhone,
                        Email = email
                    };
                    hospitalContext.ContactInfos.InsertOnSubmit(newContact);
                    hospitalContext.SubmitChanges();

                    // add new patient to database
                    Patient newPatient = new Patient
                    {
                        LoginId = newLogin.LoginId,
                        PrimaryDoctor = primaryDoctor
                    };
                    hospitalContext.Patients.InsertOnSubmit(newPatient);
                    hospitalContext.SubmitChanges();

                    // check if doctor is selected from combobox
                    if (comboBoxUserType.SelectedIndex == 2)
                    {
                        // add new doctor to database
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
            if (comboBoxGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Please enter email address.");
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
            if (comboBoxStateName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select state.");
                return false;
            }
            if (textBoxZipCode.Text == "")
            {
                MessageBox.Show("Please enter zip code.");
                return false;
            }
            if (comboBoxUserType.SelectedIndex == 0)
            {
                MessageBox.Show("Please select your role.");
                return false;
            }
            if (comboBoxUserType.SelectedIndex == 2)
            {
                if (comboBoxExpertise.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select your expertise.");
                    return false;
                }
            }
            return result;
        }

        // function to handle button clear click. this allow to user to clear form
        // when they make a mistake 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxDOB.Clear();
            textBoxEmail.Clear();
            textBoxHomePhone.Clear();
            textBoxMobilePhone.Clear();
            textBoxAddressNumber.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxZipCode.Clear();
            textBoxPrimaryDoctor.Clear();
            comboBoxEthnicity.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
            comboBoxUserType.SelectedIndex = 0;
            comboBoxStateName.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function to handle combobox user type
        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUserType.SelectedIndex == 2) // doctor
            {
                string[] expertiseType = { "Select expertise","Primary care physician", "Allergists", "Anesthesiologists", "Cardiologists",
                                        "Colon and Rectal Surgeons", "Dermatologists", "Endocrinologists", "Gastroenterologists"};
                comboBoxExpertise.DataSource = expertiseType;
                comboBoxExpertise.SelectedIndex = 0;

                // display expertise label and combobox expertise
                comboBoxExpertise.Visible = true;
                labelExpertise.Visible = true;

                // hide primary doctor label and textbox
                labelPrimaryDoctor.Visible = false;
                textBoxPrimaryDoctor.Visible = false;
            }
            else if (comboBoxUserType.SelectedIndex == 1) // patient
            {
                // display primary doctor label and textbox
                labelPrimaryDoctor.Visible = true;
                textBoxPrimaryDoctor.Visible = true;

                // hide expertise label and combobox
                comboBoxExpertise.Visible = false;
                labelExpertise.Visible = false;
            }
            else if (comboBoxUserType.SelectedIndex == 0) // user hasn't select role
            {
                // hide every fields below
                comboBoxExpertise.Visible = false;
                labelExpertise.Visible = false;

                labelPrimaryDoctor.Visible = false;
                textBoxPrimaryDoctor.Visible = false;
            }
            else if (comboBoxUserType.SelectedIndex >= 3) // nurse and staff
            {
                // hide every fields below
                comboBoxExpertise.Visible = false;
                labelExpertise.Visible = false;

                labelPrimaryDoctor.Visible = false;
                textBoxPrimaryDoctor.Visible = false;
            }
        }
    }
}
