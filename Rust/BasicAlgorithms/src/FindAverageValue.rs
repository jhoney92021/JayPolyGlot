pub fn FindAverageValue_5Sizedi32Arr_ForIn(mut integerArray: [i32;5]) {
    let mut sum: i32 = 0;
    for i in integerArray {
        sum += i;
        println!("New number: {}, Sum: {}", i, sum);
    }
    println!("Average value is {}", sum / integerArray.len() as i32);
}