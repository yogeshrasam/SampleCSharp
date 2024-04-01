/**
 * This is my custom code ql query file
 * @name TOString
 * @kind problem
 * @problem.severity warning
 * @id csharp/example/hello-world
 */

import csharp

from Method m, MethodCall mc 
where 
  m.getName() = "ToString" and
  mc.getTarget().getName() = "ToString" 
  and mc.hasNoArguments()
  select mc ,"variable converted to string with ToString method"
