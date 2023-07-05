pub fn PrintTo255_ForIn() {
    for i in 1..256 {
        println!("{}", i);
    }
}
pub fn PrintTo255_While() {
    let mut i = 0;
    while i < 256 {
        println!("{}", i);
        i += 1;
    }
}
