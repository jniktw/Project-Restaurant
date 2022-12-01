export async function myFetch(url){

    const response = await fetch(url);
    return await response.json();
}