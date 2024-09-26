using MyClass;

namespace MyClass.Arrays {
    public class Arrays {
        private int size;
        private int[] simple;

        public Arrays(int size) {
            this.size = size;
            simple = new int[size];
            fillArray();
        }

        private void fillArray() {
            for(int i = 0; i < size; i++) {
                simple[i] = CLI.getInt("Enter Element # " + (i + 1) + ": ");
            }

            CLI.print("Success!\n\n");
        }

        public int getSize() {
            return size;
        }

        public void displayArray() {
            CLI.print("[");
            for(int i = 0; i < size; i++) {
                CLI.print(Convert.ToString(simple[i]));

                if(i != size - 1) {
                    CLI.print(", ");
                }
            }

            CLI.print("]\n");
        }

        public int getElemByIndex(int index) {
            if(index >= 0 && index < size) {
                return simple[index];
            }

            return -1;
        }
    }
}