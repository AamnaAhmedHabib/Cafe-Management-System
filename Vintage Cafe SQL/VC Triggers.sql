

--Work Around for the foreign key constraint issue when deleting user
Create Trigger tr_DeleteUser
On Users
Instead Of Delete
As
Begin
    Update Users 
    Set Status = 'Inactive' 
    Where UserID in (Select UserID From deleted);
End

