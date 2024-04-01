/**
 * This is an automatically generated file
 * @name Hello world
 * @kind problem
 * @problem.severity warning
 * @id csharp/example/hello-world
 */

import csharp
import semmle.code.csharp.dataflow.Nullness

from Dereference d, Ssa::SourceVariable v
where d.isFirstAlwaysNull(v)
select d, "Variable $@ is always null at this dereference.", v, v.toString()