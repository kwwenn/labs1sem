#include <stdio.h>
#include <ctype.h>

int main() {
    FILE *in = fopen("file.txt", "r");
    FILE *out = fopen("file1.txt", "w");
    
    char str[1000];
    
    while (fgets(str, 1000, in)) {
        int letters[26] = {0};
        
        // Считаем все буквы
        for (int i = 0; str[i] != '\0'; i++) {
            char c = str[i];
            if (c >= 'A' && c <= 'Z') {
                letters[c - 'A']++;
            }
            if (c >= 'a' && c <= 'z') {
                letters[c - 'a']++;
            }
        }
        
        // Ищем самую редкую букву
        int min = 1000000;
        for (int i = 0; i < 26; i++) {
            if (letters[i] > 0 && letters[i] < min) {
                min = letters[i];
            }
        }
        
        // Выводим все самые редкие буквы
        for (int i = 0; i < 26; i++) {
            if (letters[i] == min) {
                fprintf(out, "%c", 'a' + i);
            }
        }
        
        fprintf(out, " %d\n", min);
    }
    
    fclose(in);
    fclose(out);
    return 0;
}