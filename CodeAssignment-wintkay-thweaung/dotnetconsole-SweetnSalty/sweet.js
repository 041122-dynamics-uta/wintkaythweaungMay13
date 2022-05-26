function sumOfMultiples(number) {    
 startnum= console.log('Please enter the fist number ')
 fnum= console.log('Please enter the fist number ')
 totalnum = startnum-fnum;
let a=0;
let b=0;
  let c = 0;   
   for(let i=1; i<1000; i++)
    { 
      for (let i=1 ;i<20;i++)   
      {
        if(i % 3 === 0 || i % 5 === 0){            
           a+= i;    
          console.log('sweetnsalty')  ;  
        }    
        else if(i % 3 === 0 || i % 5 === 0){            
          b += i;   
          console.log('sweet');     
        }  
        else if(i % 3 === 0 || i % 3 === 0){
            //sum            
          c += i;        
          console.log('salty');
        } 
      
      }     
      console.log('Total Sweet&Salty' +a);
      console.log('Total Salty' +b);
      console.log('Total Sweet' +c);
    
     
  }    
  return sum;
}

