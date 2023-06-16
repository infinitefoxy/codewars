function twoSum(numbers, target) {
  // ...
  let numberMap = new Map();

  for (let index = 0; index < numbers.length; index++) {
    var ele = numbers[index];

    if (numberMap.has(target - ele)) 
      return [index, numberMap.get(target - ele)];
    else numberMap.set(ele, index);
  }

  return [];
  
}