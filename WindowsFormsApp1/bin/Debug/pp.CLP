
(deffunction temp-predctions(?t)
   (if (< ?t 20)then Cold 
     else
     (if (> ?t 20)then printout t hot)
   )
)


(deffunction month-predctions(?m)
   (if (eq ?m 0)then winnter
     else
     (if (eq ?m 1)then winter 
     else
     (if (eq ?m 2)then winter 
     else (if (eq ?m 3)then spring 
     else (if (eq ?m 4)then spring 
     else (if (eq ?m 5)then spring 
     else (if (eq ?m 6)then summer 
     else (if (eq ?m 7)then summer  
     else (if (eq ?m 8)then summer  
     else (if (eq ?m 9)then autumn 
     else (if (eq ?m 10)then autumn 
     else (if (eq ?m 11)then autumn)))))))))))
   )
)

(deffunction sun-predctions(?s)
   (if (eq ?s 0)then sunny
     else
     (if (eq ?s 1)then PCloudy 
     else
     (if (eq ?s 2)then Cloudy))
   )
)


(deffunction wind-predctions(?w)
   (if (eq ?w 0)then heavy
     else
     (if (eq ?w 1)then dusty 
     else
     (if (eq ?w 2)then fine))
   )
)

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