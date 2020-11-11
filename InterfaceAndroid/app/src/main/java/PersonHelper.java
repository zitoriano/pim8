import android.widget.EditText;

import com.example.multiactivityforms.Person;

public class PersonHelper {
    private Person people;
    private EditText nome;
    private EditText cpf;

    public PersonHelper(EditText nome, EditText cpf) {
        this.nome = nome;
        this.cpf = cpf;

        this.people = new Person();
        this.people.setNome(nome.getText().toString());
        this.people.setCpf(1L);
    }
}
