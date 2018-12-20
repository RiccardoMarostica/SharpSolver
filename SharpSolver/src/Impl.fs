
(*
 * SharpSolver - Progetto di Programmazione e Calcolo a.a. 2018-19
 * Impl.fsi: implementazioni degli studenti
 * (C) 2018 Alvise Spano' @ Universita' Ca' Foscari di Venezia
 *)

module SharpSolver.Impl

open Absyn
open Prelude
open System

let rationalize (x : float) : rational = raise (NotImplementedException ())

let monomial_degree (m : monomial) : int = raise (NotImplementedException ())
let monomial_negate (m : monomial) : monomial = raise (NotImplementedException ())
let polynomial_degree (p : polynomial) : int = raise (NotImplementedException ())
let polynomial_negate (p : polynomial) : polynomial = raise (NotImplementedException ())
let normalized_polynomial_degree (np : normalized_polynomial) : int = raise (NotImplementedException ())

let normalize (p : polynomial) : normalized_polynomial = raise (NotImplementedException ())
let derive (p : polynomial) : polynomial = raise (NotImplementedException ())
let reduce (e : expr) : polynomial = raise (NotImplementedException ())

let solve0 (np : normalized_polynomial) : bool = raise (NotImplementedException ())
let solve1 (np : normalized_polynomial) : rational = raise (NotImplementedException ())
let solve2 (np : normalized_polynomial) : (float * float option) option = raise (NotImplementedException ())




