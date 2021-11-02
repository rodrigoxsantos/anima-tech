var year = 0;
var minYear = 16;
var obrigatoryYear = 18;
var maxYear = 65;





function voteStatus(){
    if(year <= minYear && year < obrigatoryYear){
        console.log('the vote is not obrigatory')
    }else if(year >= obrigatoryYear < maxYear ){
        console.log('Vote is obrigatory')
    }else('vote is optional')
}
return voteStatus(year = 29);
