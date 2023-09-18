# Cs boxing


## Nulling around

Found that Null<Float> and probably also Null<Int> will through Null.cs perform a type cast from obj to double/int(unless it's null of course). The mean function exist in RunTime.hx and is called toInt/toDouble. 

I'm not sure if I found a solution. But e.g. when creating a class or struct with a nullable member variable, you can skip the typecasting by declaring the class generic