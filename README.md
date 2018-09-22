# Library-Management-System
INTRODUCTION:
This is an .Net Windows Application of Library Management System. There are two users validation in this
application. In this application,  User can register itself by providing username and password. After registration
User will Login by username & password. After Registration User must have to pay Security Amount for 
registration in library management system. User can Issued the books from library, and return it to back. On 
Returning books to the library user must have to pay the amount of book as per calculate by number of days book
issued to user. Books Payment should be Deducted from Security amount of User. 

APPLICATIONS USERS:
"ADMIN" is the super user account which having some special permissions as compare to normal Users.

"ADMIN" Rights:
1 - Add/Remove Books Categories.
2 - Add/Remove Books.
3 - See the quantity of books available in Library.
3 - See the Issuing books record to which user and how many days book issue to user and how much charge given
     by user when returns books.
4 - See the list of Users who currently issuing how many books.
5 - See the currently available security amount remaining of users.
6 - Admin have permission to change his/her password
Username:	"admin"
Password:	"admin"

"Users" Rights:
1 - User can Search/Issue Books from Library.
2 - User can Return His/Her Books to Library.
3 - User can see the records of books, Price of each book for issuing in Library.
4 - User can see the Currently Issued Books By Him/Her.
5 - User can Change his/her password.

VALIDATIONS:
1 - Users cannot create already registered User with same username.
2 - Users does not have permission to create another administrator account.
3 - Users cannot Issue more than 3 Books concurrent.
4 - Issued books more than 3, users have to first return the issuing books.
5 - Users cannot ses the list of Another users which books issued to other users.
