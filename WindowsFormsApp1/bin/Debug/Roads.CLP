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