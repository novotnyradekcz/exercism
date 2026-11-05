/**
* Your implmentation of the Diamond exercise
*/
component {
	
	/**
	* @returns 
	*/
	array function rows( letter ) {
	    letter = uCase(letter);
		var num = asc( letter ) - asc('A') + 1;
		var result = [];
		var curLetter = '';
	    var padding = num - 1;
	    var center = 0;
	    var resultBottom = [];
		for(var i = 0; i < num; i++){
		    var curLetter = chr(asc('A') + i);
		    result.append( 
		       repeatString(" ", padding)
		       & curLetter
		       & repeatString(" ", center)
		       & (center > 0 ? curLetter : "")
		       & repeatString(" ", padding)
		    );
		    if(i+1!=num){
		        resultBottom.prepend( result[arrayLen(result)] );
		    }
		    padding--;
		    center = ( (num-1)*2+1) - (padding*2) - 2;
		}
		arrayAppend(result, resultBottom, true);
		return result;
	}
	
}