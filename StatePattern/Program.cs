using StatePattern;

var atm = new ATMMachine();

//Initially No Card State

atm.WithdrawCash(); // Output: Please insert your card first.

//Changes to Card Inserted State
atm.InsertCard(); // Output: Card inserted successfully.

//These actions are valid in Card Inserted State
atm.InsertCard(); // Output: Card is already inserted.
atm.WithdrawCash(); // Output: Cash withdrawn successfully.

//Returns to No Card State after cash withdrawal changes to No Card State
atm.PressCancel(); // Output: No operation to cancel.

//These actions are valid in No Card State
atm.RemoveCard(); // Output: No card to remove.
atm.WithdrawCash(); // Output: Please insert your card first.
atm.PressCancel(); // Output: No operation to cancel.