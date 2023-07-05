pub fn PrintOddsTo255_ForIn() {
    for i in 1..256 {
        if i % 2 == 1 {
            println!("{}", i);
        }
    }
}

pub fn PrintOddsTo255_While() {
    let mut i = 0;
    while i < 256 {
        if i % 2 == 1 {
            println!("{}", i);
        }
        i += 1;
    }
}