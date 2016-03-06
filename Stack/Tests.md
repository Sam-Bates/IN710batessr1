
|Method|Situation|Result|
|:---|:---|:---|
|Stack()       |Constructor||
||||
|void Push()   |Push a string onto a new stack then call Peek|Return the latest string|
|              |Push strings onto stack and call Count|Return number of strings in the stack|
||||
|String Pop()  |Pop called on a new stack|Throw an exception with an appropriate error message|
|              |Push n items onto stack and then Pop|Return last string|
|              |Push one string onto stack and then Pop|Return last string|
||||
|String Peek() |Peek called on empty stack|Should throw an exception with an appropriate error message|
|              |Push several items onto a stack, then call Peek|Should return last pushed item, but not delete it from stack|
||||
|int Count()   |Count is called on a newly created stack|Return 0|
|              |Push n items onto a stack, then call Count|Return n|
|              |Count is called on a stack that all strings have been popped|Return 0|
||||
|IsEmpty()     |IsEmpty is ca,led on a newly created stack|Return true|
|              |IsEmpty is called on a stack that all strings have been popped|Return true|
|              |IsEmpty is called on a stack that has strings in it|Return false|
