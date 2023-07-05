mod PrintTo255;
mod PrintOddsTo255;
mod PrintSum;
mod FindAverageValue;
mod TestValues;

fn main() {
    println!("Hello, world!");
    // PrintTo255::PrintTo255_ForIn();
    // PrintTo255::PrintTo255_While();
    // PrintOddsTo255::PrintOddsTo255_ForIn();
    // PrintOddsTo255::PrintOddsTo255_While();
    // PrintSum::PrintSum_ForIn();
    // PrintSum::PrintSum_While();
    let testArray = TestValues::TestIntegerArray();
    let testArray1 = TestValues::TestIntegerArray_1();
    FindAverageValue::FindAverageValue_5Sizedi32Arr_ForIn(testArray);
    FindAverageValue::FindAverageValue_5Sizedi32Arr_ForIn(testArray1);
}
