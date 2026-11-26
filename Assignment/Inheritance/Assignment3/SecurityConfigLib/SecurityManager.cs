//ecurity Configuration

//A banking application contains a SecurityManager class that 
//    contains important security-related functionality.

//The company does not want any other class to inherit from SecurityManager.

//Create a sealed class SecurityManager containing:

//Login()
//Logout()
//ValidateUser()
//Task: Try creating a derived class CustomSecurityManager and observe what happens.


namespace SecurityConfigLib
{
    sealed class SecurityManager
    {
        public string Login()
        {
            return "logged in succesfully";
        }

        public string Logout()
        {
            return "logged out succesfully";
        }

        public string ValidateUser()
        {
            return "user validated";
        }
    }
}
