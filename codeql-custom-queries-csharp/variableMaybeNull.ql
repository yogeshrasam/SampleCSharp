/**
 * This is an automatically generated file
 * @name Hello world
 * @kind problem
 * @problem.severity warning
 * @id csharp/example/hello-world
 */

 import semmle.code.csharp.dataflow.Nullness
 import PathGraph
 
 from
   Dereference d, PathNode source, PathNode sink, Ssa::SourceVariable v, string msg, Element reason
 where d.isFirstMaybeNull(v.getAnSsaDefinition(), source, sink, msg, reason)
 select d, source, sink, "Variable $@ may be null at this access " + msg + ".", v, v.toString(),
   reason, "this"