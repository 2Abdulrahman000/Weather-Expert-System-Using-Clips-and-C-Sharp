;1-Create template and facts (manual or by function) 
(deftemplate weateher (slot temprature) (slot month) (slot sun) (slot wind))
 
(assert(weateher (temprature 20) (month "january") (sun "low") (wind "High")))

(assert(weateher (temprature 15) (month "february") (sun "low") (wind "High")))

(assert(weateher (temprature 12) (month "march") (sun "Medium") (wind "High")))

(assert(weateher (temprature 22) (month "april") (sun "High") (wind "Meduim")))

(assert(weateher (temprature 30) (month "May") (sun "Medium") (wind "High")))

(assert(weateher (temprature 28) (month "june") (sun "High") (wind "Low")))

(assert(weateher (temprature 35) (month "july") (sun "High") (wind "Low")))

(assert(weateher (temprature 33) (month "Agust") (sun "High") (wind "Low")))

(assert(weateher (temprature 39) (month "septemper") (sun "High") (wind "Low")))

(assert(weateher (temprature 25) (month "Octoper") (sun "Medium") (wind "Medium")))

(assert(weateher (temprature 25) (month "Novemper") (sun "Medium") (wind "Medium")))

(assert(weateher (temprature 25) (month "december") (sun "Medium") (wind "Medium")))
;=====================================================================================================
;rules
;2-find Season or months by its attribute
(defrule r1
(weateher (temprature ?n) (month "Novemper") (sun "Medium") (wind "Medium"))
(test (and (> ?n 20) (< ?n 30)) )
=>
(printout t "its may be Octoper or Novemper or december "crlf)
)
;------------------------------------------------------------------------------------------------------
(defrule r2
(weateher (temprature ?n) (month "May") (sun "Medium") (wind "High"))
(test (> ?n 35))
=>
(printout t "its may be Agust or May "crlf)
)
;------------------------------------------------------------------------------------------------------
(defrule r3
(weateher (temprature ?n) (month "january") (sun "low") (wind "High"))
(test(eq ?n 20))
=>
(printout t "it may be January" crlf)
)
;------------------------------------------------------------------------------------------------------
(defrule r4
(weateher (temprature ?n) (month ?m) (sun ?s) (wind ?w))
(test (eq ?w "High"))
=>
(printout t "it may be Winnter" crlf)
)
;------------------------------------------------------------------------------------------------------
(defrule r5
(weateher (temprature ?n) (month ?m) (sun ?s) (wind ?w))
(test (> ?n 30))
=>
(printout t "it may be Summer" crlf)
)
;=====================================================================================================
;3-add fact
(deffunction add-fact(?t ?m ?s ?w)
	(assert(weateher (temprature ?t) (month ?m) (sun ?s) (wind ?w)))
)
;=====================================================================================================
;4-delete fact
(deffunction remove-fact(?n)
	(retract ?n)
)
;=====================================================================================================
;5-predctions about temprature 
(deffunction temp-predctions(?t)
   (if (< ?t 20)then Cold 
     else
     (if (> ?t 20)then hot)
   )
)
;=====================================================================================================
;6-predctions about month
(deffunction month-predctions(?m)
   (if (eq ?m "january")then winnter
     else
     (if (eq ?m "may")then summer 
     else
     (if (eq ?m "septemper")then spring))
   )
)
;=====================================================================================================
;7-predctions about sun
(deffunction sun-predctions(?s)
   (if (eq ?s "high")then sunny
     else
     (if (eq ?s "medium")then PCloudy 
     else
     (if (eq ?s "low")then Cloudy))
   )
)
;=====================================================================================================
;8-predctions about wind
(deffunction wind-predctions(?w)
   (if (eq ?w "high")then heavy
     else
     (if (eq ?w "medium")then dusty 
     else
     (if (eq ?w "low")then fine))
   )
)
;=====================================================================================================
;9-predctions about Roads
(deffunction road-predctions(?r)
	(if(eq ?r 0)then printout t "Safe" 
	else (if(eq ?r 1)then printout t "Heavy rain" 
	else (if(eq ?r 2)then printout t "Dusty" 
	else (if(eq ?r 3)then printout t "Cloudy" 
	else (if(eq ?r 4)then printout t "Heavy rain" 
	else (if(eq ?r 5)then printout t "Dusty" 
	else (if(eq ?r 6)then printout t "Safe" 
	else (if(eq ?r 7)then printout t "Cloudy" 
	else (if(eq ?r 8)then printout t "Cloudy")))))))))
)
;=====================================================================================================
;10-predctions about Captials
(deffunction captial-predctions(?c)
	(if(eq ?c 0)then printout t "33/20 fine" 
	else (if(eq ?c 1)then printout t "30/24 dusty" 
	else (if(eq ?c 2)then printout t "26/14 cold" 
	else (if(eq ?c 3)then printout t "36/24 hot" 
	else (if(eq ?c 4)then printout t "12/4 very cold" 
	else (if(eq ?c 5)then printout t "44/20 very hot" 
	else (if(eq ?c 6)then printout t "4/-8 very cold" 
	else (if(eq ?c 7)then printout t "24/8 cold" 
	else (if(eq ?c 8)then printout t "30/22 fine")))))))))
)