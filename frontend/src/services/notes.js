import {ActionCreators} from '../redux/notesReducer'

export const GetNotes = async (dispatch) => {
    try{
        // fake api call
        const response = [
            {value: 'study for exam in 1 weeks', id: 1},
            {value: 'study for exam in 2 weeks', id: 2},
            {value: 'study for exam in 3 weeks', id: 3},
            {value: 'study for exam in 4 weeks', id: 4},
        ];

        dispatch(ActionCreators.setNotes(response));
    }catch{
        console.log('Error!');
    }
}

export const DeleteNote = async (dispatch, note) => {
    try{
        // fake api call      
        dispatch(ActionCreators.deleteNote(note));
    }catch{
        console.log('Error!');
    }
}

export const NewNote = async (dispatch, note) => {
    try{
        // fake api call
        const response = {value: note, id: 1};
        dispatch(ActionCreators.newNote(response));
    }catch{
        console.log('Error!');
    }
}

export const EditNote = async (dispatch, note) => {
    try{
        // fake api call
        const response = {value: note, id: 1};
        dispatch(ActionCreators.editNote(response));
    }catch{
        console.log('Error!');
    }
}