pub fn PrintSum_ForIn() {
    let mut sum = 0;
    for i in 1..256 {
        sum += i;
        println!("New number: {}, Sum: {}", i, sum);
    }
}
pub fn PrintSum_While() {
    let mut sum = 0;
    let mut i = 0;
    while i < 256 {
        sum += i;
        println!("New number: {}, Sum: {}", i, sum);
        i += 1;
    }
}