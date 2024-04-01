/**
 * This is an automatically generated file
 * @name Hello world
 * @kind problem
 * @problem.severity warning
 * @id csharp/example/hello-world
 */

import csharp

from Method m, MethodCall mc,LocalVariableAccess lva
where 
  m.getName() = "ToString" and
  mc.getTarget().getName() = "ToString" and
  m = mc.getTarget()  
select m, lva