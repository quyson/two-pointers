const getSolution = (array) => {
    array.sort((a,b) => a- b)
    let result = [];

    for(let i = 0; i < array.length - 2; i++){
        if(i > 0 && array[i - 1] == array[i]){
            continue
        }
        let l = i + 1
        let r = array.length - 1
        while(l < r){
            if(array[l] + array[r] + array[i] > 0){
                r--;
            }
            if(array[l] + array[r] + array[i] < 0){
                l++;
            }
            if(array[l] + array[r] + array[i] === 0){
                result.push([array[i], array[l], array[r]]);
                while(l < r && array[r] === array[r-1]){
                r--;
                }
                while(l < r  && array[l] === array[l+1]){
                l++;
                }
            }
            
        } 

    } return result
}